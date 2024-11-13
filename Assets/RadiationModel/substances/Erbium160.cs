
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium160";
        public override double halfLife { get; } = 102888.0d;
        public override double atomicWeight { get; } = 159.92908d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Holmium160() } },

        };
    }
}
    
    