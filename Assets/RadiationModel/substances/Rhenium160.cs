using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium160";
        public override double halfLife { get; } = 0.00061d;
        public override double atomicWeight { get; } = 159.98188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tungsten159() } },
            { 0.11d, new List<RadioactiveSubstance> { new AlphaParticle(7715047.4), new Tantalum156() } },

        };
    }
}
    
    