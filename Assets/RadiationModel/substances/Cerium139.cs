
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium139";
        public override double halfLife { get; } = 11892268.8d;
        public override double atomicWeight { get; } = 138.90665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Lanthanum139() } },

        };
    }
}
    
    