using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon31 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon31";
        public override double halfLife { get; } = 9434.4d;
        public override double atomicWeight { get; } = 30.97536d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus31() }, { 1.0d, new BetaParticle(-1, 745752.2) }, { 0.000554d, new GammaParticle(1266100.0, 0.00098) }, { 1.29441984768e-11d, new GammaParticle(149.0, 8.32109) }, { 1.9229534072521144e-10d, new GammaParticle(2013.0, 0.61592) }, { 3.809337177599276e-10d, new GammaParticle(2014.0, 0.61561) }, { 2.464884951486098e-11d, new GammaParticle(2138.0, 0.57991) }, { 2.464884951486098e-11d, new GammaParticle(2138.0, 0.57991) } } },

        };
    }
}
    