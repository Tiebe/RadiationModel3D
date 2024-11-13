
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium111";
        public override double halfLife { get; } = 242334.72d;
        public override double atomicWeight { get; } = 110.90511d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Cadmium111() } },

        };
    }
}
    
    