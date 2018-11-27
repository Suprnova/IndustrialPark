﻿using HipHopFile;
using RenderWareFile;
using SharpDX;
using System;
using System.Collections.Generic;

namespace IndustrialPark
{
    public class AssetMODL : Asset, IAssetWithModel
    {
        RenderWareModelFile model;

        public AssetMODL(Section_AHDR AHDR) : base(AHDR)
        {
        }

        public void Setup(SharpRenderer renderer)
        {
            model = new RenderWareModelFile(AHDR.ADBG.assetName);
            try
            {
                RWSection[] rw = ReadFileMethods.ReadRenderWareFile(AHDR.data);
                model.SetForRendering(renderer.device, rw, AHDR.data);
                ArchiveEditorFunctions.AddToRenderingDictionary(AHDR.assetID, this);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ToString() + " (MODL) has an unsupported format and cannot be rendered. " + ex.Message);
            }
        }

        public void Draw(SharpRenderer renderer, Matrix world, Vector4 color)
        {
            model.Render(renderer, world, isSelected ? renderer.selectedObjectColor * color : color);
        }

        public RenderWareModelFile GetRenderWareModelFile()
        {
            return model;
        }

        public bool HasRenderWareModelFile()
        {
            return model != null;
        }

        public string[] Textures
        {
            get
            {
                List<string> textures = new List<string>();
                foreach (string s in model.MaterialList)
                    if (!textures.Contains(s))
                        textures.Add(s);
                return textures.ToArray();
            }
        }

        public override bool HasReference(uint assetID)
        {
            foreach (string s in Textures)
            {
                if (Functions.BKDRHash(s + ".RW3") == assetID)
                    return true;
                if (Functions.BKDRHash(s) == assetID)
                    return true;
            }

            return base.HasReference(assetID);
        }
    }
}