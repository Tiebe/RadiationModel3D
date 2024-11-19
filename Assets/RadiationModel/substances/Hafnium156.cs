using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium156";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 155.9594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7047002.09), new Ytterbium152() } },

        };
    }
}
    
    