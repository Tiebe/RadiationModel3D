using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium128p : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium128p";
        public override double halfLife { get; } = 0.0063d;
        public override double atomicWeight { get; } = 127.93242d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00029, 4287000.0), new Cadmium128() } },

        };
    }
}
    
    