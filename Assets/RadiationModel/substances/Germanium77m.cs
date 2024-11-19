using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium77m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium77m";
        public override double halfLife { get; } = 53.7d;
        public override double atomicWeight { get; } = 76.92372d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2863140.0), new Arsenic77() } },
            { 0.19d, new List<RadioactiveSubstance> { new GammaParticle((159710.00001, 0.00776)), new Germanium77() } },

        };
    }
}
    
    