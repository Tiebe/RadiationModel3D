
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine224 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine224";
        public override double halfLife { get; } = 150.0d;
        public override double atomicWeight { get; } = 224.02975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon224() } },

        };
    }
}
    
    