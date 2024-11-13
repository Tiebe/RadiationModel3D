
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

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lawrencium255() } },

            { 0.0015d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mendelevium251() } },

        };
    }
}
    
    