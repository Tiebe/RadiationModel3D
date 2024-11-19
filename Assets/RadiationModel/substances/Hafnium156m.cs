using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium156m";
        public override double halfLife { get; } = 0.00048d;
        public override double atomicWeight { get; } = 155.9615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9007002.09), new Ytterbium152() } },

        };
    }
}
    
    