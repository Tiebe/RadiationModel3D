using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium53";
        public override double halfLife { get; } = 0.461d;
        public override double atomicWeight { get; } = 52.96845d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium53() }, { 1.0d, new BetaParticle(-1, 4690000.0) }, { 0.56d, new GammaParticle(2109000.0, 0.00059) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium53() }, { 1.0d, new BetaParticle(-1, 4690000.0) }, { 0.56d, new GammaParticle(2109000.0, 0.00059) } } },

        };
    }
}
    