
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium234";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 234.05038d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Actinium234() } },

        };
    }
}
    
    