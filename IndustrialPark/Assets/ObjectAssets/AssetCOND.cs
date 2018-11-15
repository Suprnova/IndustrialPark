﻿using HipHopFile;

namespace IndustrialPark
{
    public enum CONDOperation
    {
        EQUAL_TO = 0,
        GREATER_THAN = 1,
        LESS_THAN = 2,
        GREATER_THAN_OR_EQUAL_TO = 3,
        LESS_THAN_OR_EQUAL_TO = 4,
        NOT_EQUAL_TO = 5
    }

    public enum CONDVariable : uint
    {
        SoundMode = 0x29600EB0,
        MusicVolume = 0x84D4A26D,
        SFXVolume = 0x1E0EEB55,
        MemoryCardAvailable = 0x42453758,
        IsVibrationOn = 0x3B93C93F,
        LetterOfScene = 0x704D04A9,
        Room = 0x0B11B427,
        CurrentLevelCollectable = 0x9653DA31,
        PatSocks = 0x18249056,
        TotalPatsSocks = 0xD1FEEEE2,
        ShinyObjects = 0xD6FCCFE7,
        GoldenSpatulas = 0xC7E0F71C,
        CurrentDate = 0x9482683D,
        CurrentHour = 0x950F49B7,
        CurrentMinute = 0xBD2884E7,
        CounterValue = 0x4329EFFD,
        IsEnabled = 0xA6956B3F,
        IsVisible = 0x1E42996C
    }

    public class AssetCOND : ObjectAsset
    {
        public AssetCOND(Section_AHDR AHDR) : base(AHDR) { }

        public override bool HasReference(uint assetID)
        {
            if (AssetUnderEvaluation == assetID)
                return true;
            if ((uint)Conditional == assetID)
                return true;

            return base.HasReference(assetID);
        }

        protected override int EventStartOffset
        {
            get => 0x18;
        }

        public CONDVariable Conditional
        {
            get => (CONDVariable)ReadUInt(0xC);
            set => Write(0xC, (uint)value);
        }

        public CONDOperation Operation
        {
            get => (CONDOperation)ReadInt(0x10);
            set => Write(0x10, (int)value);
        }

        public int EvaluationAmount
        {
            get => ReadInt(0x8);
            set => Write(0x8, value);
        }

        public AssetID AssetUnderEvaluation
        {
            get => ReadUInt(0x14);
            set => Write(0x14, value);
        }
    }
}