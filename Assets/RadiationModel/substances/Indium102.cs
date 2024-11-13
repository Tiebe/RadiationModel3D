
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium102";
        public override double halfLife { get; } = 23.3d;
        public override double atomicWeight { get; } = 101.92411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium102() } },

        };
    }
}
    
    