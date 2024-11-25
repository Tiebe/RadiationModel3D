using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin129 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin129";
        public override double halfLife { get; } = 133.8d;
        public override double atomicWeight { get; } = 128.91348d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony129() }, { 1.0d, new BetaParticle(-1, 2019000.0) }, { 0.005192d, new GammaParticle(251700.0, 0.00493) }, { 0.011264000000000001d, new GammaParticle(266100.0, 0.00466) }, { 0.00264d, new GammaParticle(332200.0, 0.00373) }, { 0.005808d, new GammaParticle(339100.0, 0.00366) }, { 0.008095999999999999d, new GammaParticle(342200.0, 0.00362) }, { 0.006071999999999999d, new GammaParticle(349000.0, 0.00355) }, { 0.003872d, new GammaParticle(353100.0, 0.00351) }, { 0.016191999999999998d, new GammaParticle(410200.0, 0.00302) }, { 0.02112d, new GammaParticle(579300.0, 0.00214) }, { 0.88d, new GammaParticle(645190.0, 0.00192) }, { 0.005456d, new GammaParticle(688000.0, 0.0018) }, { 0.021472d, new GammaParticle(848270.0, 0.00146) }, { 0.01496d, new GammaParticle(858200.0, 0.00144) }, { 0.005632000000000001d, new GammaParticle(862200.0, 0.00144) }, { 0.00968d, new GammaParticle(890300.0, 0.00139) }, { 0.055439999999999996d, new GammaParticle(913540.0, 0.00136) }, { 0.019096d, new GammaParticle(928800.0, 0.00133) }, { 0.021032000000000002d, new GammaParticle(1117060.0, 0.00111) }, { 0.008008d, new GammaParticle(1140600.0, 0.00109) }, { 0.00792d, new GammaParticle(1161420.0, 0.00107) }, { 0.026136d, new GammaParticle(1196980.0, 0.00104) }, { 0.015136d, new GammaParticle(1203800.0, 0.00103) }, { 0.040304d, new GammaParticle(1252210.0, 0.00099) }, { 0.010208d, new GammaParticle(1281800.0, 0.00097) }, { 0.006071999999999999d, new GammaParticle(1327690.0, 0.00093) }, { 0.014696d, new GammaParticle(1470400.0, 0.00084) }, { 0.0022d, new GammaParticle(1479300.0, 0.00084) }, { 0.01672d, new GammaParticle(1503630.0, 0.00082) }, { 0.0063360000000000005d, new GammaParticle(1509900.0, 0.00082) }, { 0.01276d, new GammaParticle(1535900.0, 0.00081) }, { 0.013024d, new GammaParticle(1614600.0, 0.00077) }, { 0.01496d, new GammaParticle(2102700.0, 0.00059) }, { 0.0044d, new GammaParticle(2448900.0, 0.00051) } } },

        };
    }
}
    