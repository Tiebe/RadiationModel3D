
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium153m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 152.95888d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Ytterbium152() } },

        };
    }
}
    
    