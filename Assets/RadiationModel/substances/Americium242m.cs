using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium242m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242m";
        public override double halfLife { get; } = 4449530232.0d;
        public override double atomicWeight { get; } = 242.0596d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9954999999999999d, new List<RadioactiveSubstance> { new GammaParticle(0.02551, 48600.0), new Americium242() } },
            { 0.0045000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(6657047.4), new Neptunium238() } },
            { 4.7e-11d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    