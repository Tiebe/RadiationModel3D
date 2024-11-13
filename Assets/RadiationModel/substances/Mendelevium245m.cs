
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium245m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium245m";
        public override double halfLife { get; } = 0.0009d;
        public override double atomicWeight { get; } = 245.08098d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    