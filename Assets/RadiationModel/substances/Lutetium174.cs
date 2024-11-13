
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium174";
        public override double halfLife { get; } = 104453511.12d;
        public override double atomicWeight { get; } = 173.94034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium174() } },

        };
    }
}
    
    