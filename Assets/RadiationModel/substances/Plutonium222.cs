using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium222";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 222.03764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    