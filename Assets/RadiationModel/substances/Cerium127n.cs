
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium127n : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium127n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 126.92277d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cerium127() } },

        };
    }
}
    
    