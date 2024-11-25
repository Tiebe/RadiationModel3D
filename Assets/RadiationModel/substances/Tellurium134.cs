using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium134";
        public override double halfLife { get; } = 2508.0d;
        public override double atomicWeight { get; } = 133.9114d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine134() }, { 1.0d, new BetaParticle(-1, 754600.0) }, { 0.00029499999999999996d, new GammaParticle(29600.0, 0.04189) }, { 0.0027435d, new GammaParticle(76830.0, 0.01614) }, { 0.20945d, new GammaParticle(79445.0, 0.01561) }, { 0.003835d, new GammaParticle(101420.0, 0.01222) }, { 0.0017699999999999999d, new GammaParticle(131050.0, 0.00946) }, { 0.0008849999999999999d, new GammaParticle(137000.0, 0.00905) }, { 0.18289999999999998d, new GammaParticle(180891.0, 0.00685) }, { 0.0059d, new GammaParticle(183050.0, 0.00677) }, { 0.0885d, new GammaParticle(201235.0, 0.00616) }, { 0.22715d, new GammaParticle(210465.0, 0.00589) }, { 0.004425d, new GammaParticle(259800.0, 0.00477) }, { 0.21239999999999998d, new GammaParticle(277951.0, 0.00446) }, { 0.1888d, new GammaParticle(435060.0, 0.00285) }, { 0.09734999999999999d, new GammaParticle(460997.0, 0.00269) }, { 0.0472d, new GammaParticle(464640.0, 0.00267) }, { 0.18585000000000002d, new GammaParticle(565992.0, 0.00219) }, { 0.016815d, new GammaParticle(636260.0, 0.00195) }, { 0.00885d, new GammaParticle(645400.0, 0.00192) }, { 0.0118d, new GammaParticle(665850.0, 0.00186) }, { 0.0472d, new GammaParticle(712970.0, 0.00174) }, { 0.1534d, new GammaParticle(742586.0, 0.00167) }, { 0.295d, new GammaParticle(767200.0, 0.00162) }, { 0.0118d, new GammaParticle(844060.0, 0.00147) }, { 0.004425d, new GammaParticle(896020.0, 0.00138) }, { 0.014750000000000001d, new GammaParticle(925550.0, 0.00134) }, { 0.004425d, new GammaParticle(1027000.0, 0.00121) }, { 0.0341d, new GammaParticle(4335.0, 0.28601) }, { 0.08792433543064623d, new GammaParticle(28318.0, 0.04378) }, { 0.16330671513864456d, new GammaParticle(28613.0, 0.04333) }, { 0.04704946917676115d, new GammaParticle(32395.0, 0.03827) }, { 0.05768264921070917d, new GammaParticle(32680.0, 0.03794) }, { 0.01063318003394802d, new GammaParticle(33040.0, 0.03753) } } },

        };
    }
}
    