
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium155";
        public override double halfLife { get; } = 41.5d;
        public override double atomicWeight { get; } = 154.92814d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium155() } },

        };
    }
}
    
    