namespace MSFSBlindAssist.Aircraft;

/// <summary>
/// Aircraft definition for the default MSFS Cessna 172 Skyhawk (G1000 variant).
/// Uses only standard MSFS SimVars — no L-vars or MobiFlight required.
/// Serves as a template for other default/stock MSFS aircraft.
/// </summary>
public class Cessna172Definition : BaseAircraftDefinition
{
    public override string AircraftName => "Cessna 172 Skyhawk (G1000)";
    public override string AircraftCode => "C172";

    public override FCUControlType GetAltitudeControlType() => FCUControlType.SetValue;
    public override FCUControlType GetHeadingControlType() => FCUControlType.SetValue;
    public override FCUControlType GetSpeedControlType() => FCUControlType.SetValue;
    public override FCUControlType GetVerticalSpeedControlType() => FCUControlType.SetValue;

    public override Dictionary<string, SimConnect.SimVarDefinition> GetVariables()
    {
        var variables = GetBaseVariables();

        var aircraftVariables = new Dictionary<string, SimConnect.SimVarDefinition>
        {
            // ── FLIGHT INSTRUMENTS ────────────────────────────────────────────

            ["AIRSPEED_INDICATED"] = new SimConnect.SimVarDefinition
            {
                Name = "AIRSPEED INDICATED",
                DisplayName = "Airspeed (IAS)",
                Type = SimConnect.SimVarType.SimVar,
                Units = "knots",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["VERTICAL_SPEED"] = new SimConnect.SimVarDefinition
            {
                Name = "VERTICAL SPEED",
                DisplayName = "Vertical Speed",
                Type = SimConnect.SimVarType.SimVar,
                Units = "feet per minute",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["HEADING_INDICATOR"] = new SimConnect.SimVarDefinition
            {
                Name = "HEADING INDICATOR",
                DisplayName = "Heading Indicator",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["ATTITUDE_INDICATOR_PITCH"] = new SimConnect.SimVarDefinition
            {
                Name = "ATTITUDE INDICATOR PITCH DEGREES",
                DisplayName = "Pitch Attitude",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["ATTITUDE_INDICATOR_BANK"] = new SimConnect.SimVarDefinition
            {
                Name = "ATTITUDE INDICATOR BANK DEGREES",
                DisplayName = "Bank Attitude",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["TURN_COORDINATOR_BALL"] = new SimConnect.SimVarDefinition
            {
                Name = "TURN COORDINATOR BALL",
                DisplayName = "Turn Coordinator Ball",
                Type = SimConnect.SimVarType.SimVar,
                Units = "position",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },

            // ── NAVIGATION ────────────────────────────────────────────────────

            ["GPS_GROUND_SPEED"] = new SimConnect.SimVarDefinition
            {
                Name = "GPS GROUND SPEED",
                DisplayName = "GPS Ground Speed",
                Type = SimConnect.SimVarType.SimVar,
                Units = "knots",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["GPS_WP_BEARING"] = new SimConnect.SimVarDefinition
            {
                Name = "GPS WP BEARING",
                DisplayName = "GPS Waypoint Bearing",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["GPS_WP_DISTANCE"] = new SimConnect.SimVarDefinition
            {
                Name = "GPS WP DISTANCE",
                DisplayName = "GPS Waypoint Distance",
                Type = SimConnect.SimVarType.SimVar,
                Units = "meters",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV1_ACTIVE_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV ACTIVE FREQUENCY:1",
                DisplayName = "NAV 1 Active",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV1_STANDBY_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV STANDBY FREQUENCY:1",
                DisplayName = "NAV 1 Standby",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV2_ACTIVE_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV ACTIVE FREQUENCY:2",
                DisplayName = "NAV 2 Active",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV2_STANDBY_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV STANDBY FREQUENCY:2",
                DisplayName = "NAV 2 Standby",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV1_OBS"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV OBS:1",
                DisplayName = "NAV 1 OBS",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["NAV2_OBS"] = new SimConnect.SimVarDefinition
            {
                Name = "NAV OBS:2",
                DisplayName = "NAV 2 OBS",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["ADF1_ACTIVE_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "ADF ACTIVE FREQUENCY:1",
                DisplayName = "ADF Active",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Hz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },

            // ── COMMUNICATIONS ────────────────────────────────────────────────

            ["COM1_ACTIVE_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "COM ACTIVE FREQUENCY:1",
                DisplayName = "COM 1 Active",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["COM1_STANDBY_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "COM STANDBY FREQUENCY:1",
                DisplayName = "COM 1 Standby",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["COM2_ACTIVE_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "COM ACTIVE FREQUENCY:2",
                DisplayName = "COM 2 Active",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["COM2_STANDBY_FREQ"] = new SimConnect.SimVarDefinition
            {
                Name = "COM STANDBY FREQUENCY:2",
                DisplayName = "COM 2 Standby",
                Type = SimConnect.SimVarType.SimVar,
                Units = "MHz",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },

            // ── ENGINE ────────────────────────────────────────────────────────

            ["ENG_RPM"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG RPM:1",
                DisplayName = "Engine RPM",
                Type = SimConnect.SimVarType.SimVar,
                Units = "RPM",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["MANIFOLD_PRESSURE"] = new SimConnect.SimVarDefinition
            {
                Name = "RECIP ENG MANIFOLD PRESSURE:1",
                DisplayName = "Manifold Pressure",
                Type = SimConnect.SimVarType.SimVar,
                Units = "inHg",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["OIL_TEMPERATURE"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG OIL TEMPERATURE:1",
                DisplayName = "Oil Temperature",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Celsius",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["OIL_PRESSURE"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG OIL PRESSURE:1",
                DisplayName = "Oil Pressure",
                Type = SimConnect.SimVarType.SimVar,
                Units = "psi",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["EGT"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG EXHAUST GAS TEMPERATURE:1",
                DisplayName = "EGT",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Celsius",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["MIXTURE"] = new SimConnect.SimVarDefinition
            {
                Name = "RECIP ENG MIXTURE RATIO:1",
                DisplayName = "Mixture",
                Type = SimConnect.SimVarType.SimVar,
                Units = "percent over 100",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["THROTTLE"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG THROTTLE LEVER POSITION:1",
                DisplayName = "Throttle",
                Type = SimConnect.SimVarType.SimVar,
                Units = "percent",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },

            // ── AUTOPILOT ─────────────────────────────────────────────────────

            ["AP_MASTER"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT MASTER",
                DisplayName = "Autopilot Master",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AP_HEADING_LOCK"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT HEADING LOCK",
                DisplayName = "AP Heading Hold",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AP_HEADING_BUG"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT HEADING LOCK DIR",
                DisplayName = "AP Heading Bug",
                Type = SimConnect.SimVarType.SimVar,
                Units = "degrees",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["AP_ALTITUDE_LOCK"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT ALTITUDE LOCK",
                DisplayName = "AP Altitude Hold",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AP_ALTITUDE_BUG"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT ALTITUDE LOCK VAR",
                DisplayName = "AP Altitude Bug",
                Type = SimConnect.SimVarType.SimVar,
                Units = "feet",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["AP_NAV_LOCK"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT NAV1 LOCK",
                DisplayName = "AP NAV Hold",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AP_APPROACH_HOLD"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT APPROACH HOLD",
                DisplayName = "AP Approach Hold",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AP_VERTICAL_SPEED"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT VERTICAL HOLD VAR",
                DisplayName = "AP Vertical Speed",
                Type = SimConnect.SimVarType.SimVar,
                Units = "feet per minute",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["AP_VERTICAL_HOLD"] = new SimConnect.SimVarDefinition
            {
                Name = "AUTOPILOT VERTICAL HOLD",
                DisplayName = "AP Vertical Hold",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },

            // ── ELECTRICAL ────────────────────────────────────────────────────

            ["ELECTRICAL_MASTER_BATTERY"] = new SimConnect.SimVarDefinition
            {
                Name = "ELECTRICAL MASTER BATTERY",
                DisplayName = "Battery Master",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["ALTERNATOR_1"] = new SimConnect.SimVarDefinition
            {
                Name = "GENERAL ENG MASTER ALTERNATOR:1",
                DisplayName = "Alternator",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["AVIONICS_MASTER_SWITCH"] = new SimConnect.SimVarDefinition
            {
                Name = "AVIONICS MASTER SWITCH",
                DisplayName = "Avionics Master",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },

            // ── CONTROLS ──────────────────────────────────────────────────────

            ["FLAPS_HANDLE_INDEX"] = new SimConnect.SimVarDefinition
            {
                Name = "FLAPS HANDLE INDEX",
                DisplayName = "Flaps",
                Type = SimConnect.SimVarType.SimVar,
                Units = "number",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string>
                {
                    [0] = "Up",
                    [1] = "10 degrees",
                    [2] = "20 degrees",
                    [3] = "30 degrees"
                }
            },
            ["ELEVATOR_TRIM"] = new SimConnect.SimVarDefinition
            {
                Name = "ELEVATOR TRIM POSITION",
                DisplayName = "Elevator Trim",
                Type = SimConnect.SimVarType.SimVar,
                Units = "radians",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },

            // ── LIGHTS ────────────────────────────────────────────────────────

            ["LIGHT_NAV"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT NAV",
                DisplayName = "Nav Lights",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["LIGHT_BEACON"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT BEACON",
                DisplayName = "Beacon Light",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["LIGHT_STROBE"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT STROBE",
                DisplayName = "Strobe Lights",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["LIGHT_LANDING"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT LANDING",
                DisplayName = "Landing Light",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["LIGHT_TAXI"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT TAXI",
                DisplayName = "Taxi Light",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },
            ["LIGHT_PANEL"] = new SimConnect.SimVarDefinition
            {
                Name = "LIGHT PANEL",
                DisplayName = "Panel Lights",
                Type = SimConnect.SimVarType.SimVar,
                Units = "Bool",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string> { [0] = "Off", [1] = "On" }
            },

            // ── FUEL ──────────────────────────────────────────────────────────

            ["FUEL_LEFT_QUANTITY"] = new SimConnect.SimVarDefinition
            {
                Name = "FUEL LEFT QUANTITY",
                DisplayName = "Left Tank",
                Type = SimConnect.SimVarType.SimVar,
                Units = "gallons",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["FUEL_RIGHT_QUANTITY"] = new SimConnect.SimVarDefinition
            {
                Name = "FUEL RIGHT QUANTITY",
                DisplayName = "Right Tank",
                Type = SimConnect.SimVarType.SimVar,
                Units = "gallons",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["FUEL_TOTAL_QUANTITY"] = new SimConnect.SimVarDefinition
            {
                Name = "FUEL TOTAL QUANTITY",
                DisplayName = "Total Fuel",
                Type = SimConnect.SimVarType.SimVar,
                Units = "gallons",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest
            },
            ["FUEL_SELECTOR_1"] = new SimConnect.SimVarDefinition
            {
                Name = "FUEL TANK SELECTOR:1",
                DisplayName = "Fuel Selector",
                Type = SimConnect.SimVarType.SimVar,
                Units = "number",
                UpdateFrequency = SimConnect.UpdateFrequency.OnRequest,
                ValueDescriptions = new Dictionary<double, string>
                {
                    [0] = "Off",
                    [1] = "All",
                    [2] = "Left",
                    [3] = "Right",
                    [4] = "Specific"
                }
            },
        };

        foreach (var kvp in aircraftVariables)
        {
            variables[kvp.Key] = kvp.Value;
        }

        return variables;
    }

    public override Dictionary<string, List<string>> GetPanelStructure()
    {
        return new Dictionary<string, List<string>>
        {
            ["Instruments"] = new List<string> { "Flight Instruments", "Autopilot" },
            ["Radios"] = new List<string> { "Communications", "Navigation" },
            ["Systems"] = new List<string> { "Engine", "Electrical", "Fuel" },
            ["Controls"] = new List<string> { "Flight Controls", "Lights" }
        };
    }

    protected override Dictionary<string, List<string>> BuildPanelControls()
    {
        return new Dictionary<string, List<string>>
        {
            ["Flight Instruments"] = new List<string>
            {
                "AIRSPEED_INDICATED",
                "INDICATED_ALTITUDE",
                "VERTICAL_SPEED",
                "HEADING_INDICATOR",
                "ATTITUDE_INDICATOR_PITCH",
                "ATTITUDE_INDICATOR_BANK",
                "TURN_COORDINATOR_BALL"
            },
            ["Autopilot"] = new List<string>
            {
                "AP_MASTER",
                "AP_HEADING_LOCK",
                "AP_HEADING_BUG",
                "AP_ALTITUDE_LOCK",
                "AP_ALTITUDE_BUG",
                "AP_NAV_LOCK",
                "AP_APPROACH_HOLD",
                "AP_VERTICAL_HOLD",
                "AP_VERTICAL_SPEED"
            },
            ["Communications"] = new List<string>
            {
                "COM1_ACTIVE_FREQ",
                "COM1_STANDBY_FREQ",
                "COM2_ACTIVE_FREQ",
                "COM2_STANDBY_FREQ"
            },
            ["Navigation"] = new List<string>
            {
                "GPS_GROUND_SPEED",
                "GPS_WP_BEARING",
                "GPS_WP_DISTANCE",
                "NAV1_ACTIVE_FREQ",
                "NAV1_STANDBY_FREQ",
                "NAV1_OBS",
                "NAV2_ACTIVE_FREQ",
                "NAV2_STANDBY_FREQ",
                "NAV2_OBS",
                "ADF1_ACTIVE_FREQ"
            },
            ["Engine"] = new List<string>
            {
                "ENG_RPM",
                "MANIFOLD_PRESSURE",
                "OIL_TEMPERATURE",
                "OIL_PRESSURE",
                "EGT",
                "MIXTURE",
                "THROTTLE"
            },
            ["Electrical"] = new List<string>
            {
                "ELECTRICAL_MASTER_BATTERY",
                "ALTERNATOR_1",
                "AVIONICS_MASTER_SWITCH"
            },
            ["Fuel"] = new List<string>
            {
                "FUEL_SELECTOR_1",
                "FUEL_LEFT_QUANTITY",
                "FUEL_RIGHT_QUANTITY",
                "FUEL_TOTAL_QUANTITY"
            },
            ["Flight Controls"] = new List<string>
            {
                "FLAPS_HANDLE_INDEX",
                "ELEVATOR_TRIM"
            },
            ["Lights"] = new List<string>
            {
                "LIGHT_BEACON",
                "LIGHT_NAV",
                "LIGHT_STROBE",
                "LIGHT_LANDING",
                "LIGHT_TAXI",
                "LIGHT_PANEL"
            }
        };
    }

    public override Dictionary<string, List<string>> GetPanelDisplayVariables()
    {
        // No display-only variables for the Cessna 172
        return new Dictionary<string, List<string>>();
    }

    public override Dictionary<string, string> GetButtonStateMapping()
    {
        // No push-button/LED state mappings for the Cessna 172
        return new Dictionary<string, string>();
    }
}
