using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium255p : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255p";
        public override double halfLife { get; } = 0.00178d;
        public override double atomicWeight { get; } = 255.09813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00085, 1465000.0), new Lawrencium255() } },
            { 0.0015d, new List<RadioactiveSubstance> { new AlphaParticle(11040047.4), new Mendelevium251() } },

        };
    }
}
    
    