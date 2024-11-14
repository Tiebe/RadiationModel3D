using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium178p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178p";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 177.94647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00048), new Hafnium178() } },

        };
    }
}
    
    