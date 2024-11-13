
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium127m";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 126.92651d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium127() } },

        };
    }
}
    
    