using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten157 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten157";
        public override double halfLife { get; } = 0.275d;
        public override double atomicWeight { get; } = 156.97886d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9910000.0), new Tantalum157() } },
            { 0.0d, new List<RadioactiveSubstance> { new AlphaParticle(6207002.09), new Hafnium153() } },

        };
    }
}
    
    