
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium132";
        public override double halfLife { get; } = 0.2022d;
        public override double atomicWeight { get; } = 131.933d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin132() } },

        };
    }
}
    
    