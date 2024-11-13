
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium93m";
        public override double halfLife { get; } = 10.8d;
        public override double atomicWeight { get; } = 92.91789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.78d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium93() } },

            { 0.22d, new List<RadioactiveSubstance> { new GammaParticle(), new Ruthenium93() } },

        };
    }
}
    
    