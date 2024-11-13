
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 149.97341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Ytterbium149() } },

        };
    }
}
    
    