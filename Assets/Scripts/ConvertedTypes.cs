﻿using System;
using System.Reflection;

public enum ComponentTypeEnum
{
    Empty,
    Timer,
    Wires,
    BigButton,
    Keypad,
    Simon,
    WhosOnFirst,
    Memory,
    Morse,
    Venn,
    WireSequence,
    Maze,
    Password,
    NeedyVentGas,
    NeedyCapacitor,
    NeedyKnob,
    Mod,
    NeedyMod
}

public enum InteractionTypeEnum
{
    PushButton,
    CutWire,
    DeathBar,
    Needy,
    Rhythm,
    BigButton,
    Other
}

public static class CommonReflectedTypeInfo
{
    static CommonReflectedTypeInfo()
    {
        BombType = ReflectionHelper.FindType("Bomb");
        BombComponentsField = BombType.GetField("BombComponents", BindingFlags.Public | BindingFlags.Instance);
        HasDetonatedProperty = BombType.GetProperty("HasDetonated", BindingFlags.Public | BindingFlags.Instance);
        GetTimerMethod = BombType.GetMethod("GetTimer", BindingFlags.Public | BindingFlags.Instance);
        IsSolvedMethod = BombType.GetMethod("IsSolved", BindingFlags.Public | BindingFlags.Instance);
        NumStrikesField = BombType.GetField("NumStrikes", BindingFlags.Public | BindingFlags.Instance);
        NumStrikesToLoseField = BombType.GetField("NumStrikesToLose", BindingFlags.Public | BindingFlags.Instance);
		StrikeIndicatorField = BombType.GetField("StrikeIndicator", BindingFlags.Public | BindingFlags.Instance);
		WidgetManagerField = BombType.GetField("WidgetManager", BindingFlags.Public | BindingFlags.Instance);

		BombComponentType = ReflectionHelper.FindType("BombComponent");
        ComponentTypeField = BombComponentType.GetField("ComponentType", BindingFlags.Public | BindingFlags.Instance);
        ModuleDisplayNameField = BombComponentType.GetMethod("GetModuleDisplayName", BindingFlags.Public | BindingFlags.Instance);
        IsSolvedField = BombComponentType.GetField("IsSolved", BindingFlags.Public | BindingFlags.Instance);
        OnPassField = BombComponentType.GetField("OnPass", BindingFlags.Public | BindingFlags.Instance);
        OnStrikeField = BombComponentType.GetField("OnStrike", BindingFlags.Public | BindingFlags.Instance);
		HandlePassMethod = BombComponentType.GetMethod("HandlePass", BindingFlags.NonPublic | BindingFlags.Instance);

        TimerComponentType = ReflectionHelper.FindType("TimerComponent");
        TimeElapsedProperty = TimerComponentType.GetProperty("TimeElapsed", BindingFlags.Public | BindingFlags.Instance);
        TimeRemainingField = TimerComponentType.GetField("TimeRemaining", BindingFlags.Public | BindingFlags.Instance);
        GetFormattedTimeMethod = TimerComponentType.GetMethod("GetFormattedTime", BindingFlags.Public | BindingFlags.Instance);
		SetRateModifierMethod = TimerComponentType.GetMethod("SetRateModifier", BindingFlags.Public | BindingFlags.Instance);

		AlarmClockType = ReflectionHelper.FindType("Assets.Scripts.Props.AlarmClock");
        AlarmClockSnooze = AlarmClockType.GetMethod("ButtonDown", BindingFlags.Public | BindingFlags.Instance);
        AlarmClockTurnOff = AlarmClockType.GetMethod("TurnOff", BindingFlags.Public | BindingFlags.Instance);

        ResultPageType = ReflectionHelper.FindType("ResultPage");

        PassEventType = ReflectionHelper.FindType("PassEvent");
        StrikeEventType = ReflectionHelper.FindType("StrikeEvent");

        ComponentTypeEnumType = ReflectionHelper.FindType("Assets.Scripts.Missions.ComponentTypeEnum");

        BombBinderType = ReflectionHelper.FindType("BombBinder");

        FreeplayDeviceType = ReflectionHelper.FindType("FreeplayDevice");

		StrikeIndicatorType = ReflectionHelper.FindType("StrikeIndicator");
		StrikeCountProperty = StrikeIndicatorType.GetProperty("StrikeCount", BindingFlags.Public | BindingFlags.Instance);

		WidgetManagerType = ReflectionHelper.FindType("WidgetManager");
		GetWidgetQueryResponsesMethod = WidgetManagerType.GetMethod("GetWidgetQueryResponses", BindingFlags.Public | BindingFlags.Instance);

        RecordManagerType = ReflectionHelper.FindType("Assets.Scripts.Records.RecordManager");
        RecordManagerInstance = RecordManagerType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
        RecordManagerCurrentGameRecord = RecordManagerType.GetField("currentRecord", BindingFlags.NonPublic | BindingFlags.Instance);

        GameRecordType = ReflectionHelper.FindType("Assets.Scripts.Records.GameRecord");
        GameRecordStrikesField = GameRecordType.GetField("Strikes", BindingFlags.Public | BindingFlags.Instance);
        GameRecordCurrentStrikeIndexField = GameRecordType.GetField("currentStrikeIndex", BindingFlags.NonPublic | BindingFlags.Instance);

        StrikeSourceType = ReflectionHelper.FindType("Assets.Scripts.Records.StrikeSource");

		ModManagerType = ReflectionHelper.FindType("ModManager");
		ModManagerInstanceField = ModManagerType.GetField("Instance", BindingFlags.Public | BindingFlags.Static);
		ModMissionsField = ModManagerType.GetProperty("ModMissions", BindingFlags.Public | BindingFlags.Instance);
	}

    #region Bomb
    public static Type BombType
    {
        get;
        private set;
    }

    public static FieldInfo BombComponentsField
    {
        get;
        private set;
    }

    public static PropertyInfo HasDetonatedProperty
    {
        get;
        private set;
    } 

    public static MethodInfo GetTimerMethod
    {
        get;
        private set;
    }

    public static MethodInfo IsSolvedMethod
    {
        get;
        private set;
    }

    public static FieldInfo NumStrikesField
    {
        get;
        private set;
    }

    public static FieldInfo NumStrikesToLoseField
    {
        get;
        private set;
    }

	public static FieldInfo StrikeIndicatorField
	{
		get;
		private set;
	}

	public static FieldInfo WidgetManagerField
	{
		get;
		private set;
	}
	#endregion

	#region Bomb Component
	public static Type BombComponentType
    {
        get;
        private set;
    }

    public static FieldInfo ComponentTypeField
    {
        get;
        private set;
    }

    public static MethodInfo ModuleDisplayNameField
    {
        get;
        private set;
    }

    public static FieldInfo IsSolvedField
    {
        get;
        private set;
    }

    public static FieldInfo OnPassField
    {
        get;
        private set;
    }

    public static FieldInfo OnStrikeField
    {
        get;
        private set;
    }

	public static MethodInfo HandlePassMethod
	{
		get;
		private set;
	}
    #endregion

    #region AlarmClock
    public static Type AlarmClockType
    {
        get;
        private set;
    }

    public static MethodInfo AlarmClockSnooze
    {
        get;
        private set;
    }

    public static MethodInfo AlarmClockTurnOff
    {
        get;
        private set;
    }
    #endregion

    #region Timer Component
    public static Type TimerComponentType
    {
        get;
        private set;
    }

    public static PropertyInfo TimeElapsedProperty
    {
        get;
        private set;
    }

    public static FieldInfo TimeRemainingField
    {
        get;
        private set;
    }

    public static MethodInfo GetFormattedTimeMethod
    {
        get;
        private set;
    }

	public static MethodInfo GetFormattedStartTimeMethod
    {
        get;
        private set;
    }

	public static MethodInfo SetRateModifierMethod
	{
		get;
		private set;
	}
	#endregion

	#region Result Page
	public static Type ResultPageType
    {
        get;
        private set;
    }
    #endregion

    #region Events
    public static Type PassEventType
    {
        get;
        private set;
    }

    public static Type StrikeEventType
    {
        get;
        private set;
    }
    #endregion

    public static Type ComponentTypeEnumType
    {
        get;
        private set;
    }

    public static Type BombBinderType
    {
        get;
        private set;
    }

    public static Type FreeplayDeviceType
    {
        get;
        private set;
    }

	public static Type StrikeIndicatorType
	{
		get;
		private set;
	}

	public static PropertyInfo StrikeCountProperty
	{
		get;
		private set;
	}

	public static Type WidgetManagerType
	{
		get;
		private set;
	}

	public static MethodInfo GetWidgetQueryResponsesMethod
	{
		get;
		private set;
	}

    public static Type RecordManagerType
    {
        get;
        private set;
    }

    public static PropertyInfo RecordManagerInstance
    {
        get;
        private set;
    }

    public static FieldInfo RecordManagerCurrentGameRecord
    {
        get;
        private set;
    }

    public static Type GameRecordType
    {
        get;
        private set;
    }

    public static FieldInfo GameRecordStrikesField
    {
        get;
        private set;
    }

    public static FieldInfo GameRecordCurrentStrikeIndexField
    {
        get;
        private set;
    }

    public static Type StrikeSourceType
    {
        get;
        private set;
    }

	#region ModManager
	public static Type ModManagerType
	{
		get;
		private set;
	}

	public static FieldInfo ModManagerInstanceField
	{
		get;
		private set;
	}

	public static PropertyInfo ModMissionsField
	{
		get;
		private set;
	}
	#endregion
}
