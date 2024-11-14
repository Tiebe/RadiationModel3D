using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium172m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 171.93892d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0026), new Thulium172() } },

        };
    }
}
    
    