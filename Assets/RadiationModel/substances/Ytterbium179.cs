
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium179";
        public override double halfLife { get; } = 480.0d;
        public override double atomicWeight { get; } = 178.94993d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lutetium179() } },

        };
    }
}
    
    