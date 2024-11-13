
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium153";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 152.9588d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Ytterbium152() } },

        };
    }
}
    
    