
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten176 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten176";
        public override double halfLife { get; } = 9000.0d;
        public override double atomicWeight { get; } = 175.94563d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Tantalum176() } },

        };
    }
}
    
    