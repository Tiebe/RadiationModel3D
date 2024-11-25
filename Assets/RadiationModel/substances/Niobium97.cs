using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium97";
        public override double halfLife { get; } = 4326.0d;
        public override double atomicWeight { get; } = 96.9081d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum97() }, { 1.0d, new BetaParticle(-1, 970850.0) }, { 0.00049115d, new GammaParticle(178000.0, 0.00697) }, { 0.00049115d, new GammaParticle(238400.0, 0.0052) }, { 0.00049115d, new GammaParticle(549250.0, 0.00226) }, { 0.9823000000000001d, new GammaParticle(657940.0, 0.00188) }, { 0.0009037159999999999d, new GammaParticle(719530.0, 0.00172) }, { 0.00045185799999999997d, new GammaParticle(857460.0, 0.00145) }, { 0.000402743d, new GammaParticle(909550.0, 0.00136) }, { 0.01090353d, new GammaParticle(1024400.0, 0.00121) }, { 0.000854601d, new GammaParticle(1117020.0, 0.00111) }, { 0.00049115d, new GammaParticle(1148600.0, 0.00108) }, { 0.00147345d, new GammaParticle(1268620.0, 0.00098) }, { 0.001218052d, new GammaParticle(1515660.0, 0.00082) }, { 0.000245575d, new GammaParticle(1629090.0, 0.00076) }, { 7.649461941329999e-05d, new GammaParticle(2440.0, 0.50813) }, { 0.00038720854203173845d, new GammaParticle(17374.0, 0.07136) }, { 0.0007379617725018838d, new GammaParticle(17479.0, 0.07093) }, { 0.00019363849607138427d, new GammaParticle(19681.0, 0.063) }, { 0.0002234588244663774d, new GammaParticle(19794.0, 0.06264) }, { 2.9820328394993178e-05d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    