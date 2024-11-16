using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium106";
        public override double halfLife { get; } = 35.6d;
        public override double atomicWeight { get; } = 105.91436d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6547000.0), new Ruthenium106() } },

        };
    }
}
    
    