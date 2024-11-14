using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium159m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 158.98433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.925d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tungsten158() } },
            { 0.075d, new List<RadioactiveSubstance> { new AlphaParticle(7985047.4), new Tantalum155() } },

        };
    }
}
    
    