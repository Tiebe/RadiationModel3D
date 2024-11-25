using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium54";
        public override double halfLife { get; } = 0.526d;
        public override double atomicWeight { get; } = 53.96303d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium54() }, { 1.0d, new BetaParticle(-1, 5653000.0) }, { 0.04d, new GammaParticle(484600.0, 0.00256) }, { 0.07d, new GammaParticle(840500.0, 0.00148) }, { 0.4d, new GammaParticle(1002000.0, 0.00124) }, { 0.09d, new GammaParticle(1020800.0, 0.00121) }, { 0.79d, new GammaParticle(1495000.0, 0.00083) }, { 0.02d, new GammaParticle(1504000.0, 0.00082) }, { 0.07d, new GammaParticle(1965700.0, 0.00063) }, { 0.05d, new GammaParticle(2517500.0, 0.00049) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium54() }, { 1.0d, new BetaParticle(-1, 5653000.0) }, { 0.04d, new GammaParticle(484600.0, 0.00256) }, { 0.07d, new GammaParticle(840500.0, 0.00148) }, { 0.4d, new GammaParticle(1002000.0, 0.00124) }, { 0.09d, new GammaParticle(1020800.0, 0.00121) }, { 0.79d, new GammaParticle(1495000.0, 0.00083) }, { 0.02d, new GammaParticle(1504000.0, 0.00082) }, { 0.07d, new GammaParticle(1965700.0, 0.00063) }, { 0.05d, new GammaParticle(2517500.0, 0.00049) } } },

        };
    }
}
    