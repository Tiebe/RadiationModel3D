using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium261";
        public override double halfLife { get; } = 2400.0d;
        public override double atomicWeight { get; } = 261.10583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    