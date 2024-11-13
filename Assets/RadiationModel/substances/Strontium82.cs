
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium82";
        public override double halfLife { get; } = 2190240.0d;
        public override double atomicWeight { get; } = 81.9184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Rubidium82() } },

        };
    }
}
    
    