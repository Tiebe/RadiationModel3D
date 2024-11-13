
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium161";
        public override double halfLife { get; } = 8928.0d;
        public override double atomicWeight { get; } = 160.92786d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Dysprosium161() } },

        };
    }
}
    
    