using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium163";
        public override double halfLife { get; } = 144215270640.00003d;
        public override double atomicWeight { get; } = 162.92874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Dysprosium163() } },

        };
    }
}
    
    