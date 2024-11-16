using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium231";
        public override double halfLife { get; } = 516.0d;
        public override double atomicWeight { get; } = 231.04113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(7859047.4), new Uranium227() } },

        };
    }
}
    
    