using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium157";
        public override double halfLife { get; } = 217.8d;
        public override double atomicWeight { get; } = 156.93697d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4705000.0), new Erbium157() } },
            { 7.5e-06d, new List<RadioactiveSubstance> { new AlphaParticle(4900002.09), new Holmium153() } },

        };
    }
}
    
    