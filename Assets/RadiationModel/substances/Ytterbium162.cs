using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium162";
        public override double halfLife { get; } = 1132.2d;
        public override double atomicWeight { get; } = 161.93578d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium162() }, { 1.0d, new BetaParticle(1, 3256599.99999) }, { 0.0304d, new GammaParticle(44650.0, 0.02777) }, { 0.34d, new GammaParticle(118700.0, 0.01045) }, { 0.0079d, new GammaParticle(125580.0, 0.00987) }, { 0.0048d, new GammaParticle(126780.0, 0.00978) }, { 0.4d, new GammaParticle(163350.0, 0.00759) }, { 0.0045000000000000005d, new GammaParticle(183050.0, 0.00677) }, { 0.0031d, new GammaParticle(184900.0, 0.00671) }, { 0.00192d, new GammaParticle(194640.0, 0.00637) }, { 0.0029d, new GammaParticle(206820.0, 0.00599) }, { 0.0042d, new GammaParticle(210680.0, 0.00588) }, { 0.002d, new GammaParticle(217520.0, 0.0057) }, { 0.0022d, new GammaParticle(244830.0, 0.00506) }, { 0.0038d, new GammaParticle(290350.0, 0.00427) }, { 0.0024d, new GammaParticle(329300.0, 0.00377) }, { 0.0029d, new GammaParticle(335020.0, 0.0037) }, { 0.0042d, new GammaParticle(349440.0, 0.00355) }, { 0.001d, new GammaParticle(353570.0, 0.00351) }, { 0.0013d, new GammaParticle(357140.0, 0.00347) }, { 0.0006d, new GammaParticle(365930.0, 0.00339) }, { 0.0019d, new GammaParticle(372770.0, 0.00333) }, { 0.001d, new GammaParticle(384850.0, 0.00322) }, { 0.0016d, new GammaParticle(399860.0, 0.0031) }, { 0.0032d, new GammaParticle(406390.0, 0.00305) }, { 0.0022d, new GammaParticle(425400.0, 0.00291) }, { 0.0022d, new GammaParticle(450690.0, 0.00275) }, { 0.0029d, new GammaParticle(457380.0, 0.00271) }, { 0.0022d, new GammaParticle(540040.0, 0.0023) }, { 0.0013d, new GammaParticle(545400.0, 0.00227) }, { 0.0013d, new GammaParticle(550860.0, 0.00225) }, { 0.032d, new GammaParticle(576100.0, 0.00215) }, { 0.0064d, new GammaParticle(584070.0, 0.00212) }, { 0.0045000000000000005d, new GammaParticle(591580.0, 0.0021) }, { 0.022799999999999997d, new GammaParticle(607680.0, 0.00204) }, { 0.0068000000000000005d, new GammaParticle(616840.0, 0.00201) }, { 0.0088d, new GammaParticle(619550.0, 0.002) }, { 0.0029d, new GammaParticle(628470.0, 0.00197) }, { 0.001d, new GammaParticle(637130.0, 0.00195) }, { 0.002d, new GammaParticle(652500.0, 0.0019) }, { 0.0042d, new GammaParticle(694390.0, 0.00179) }, { 0.0026d, new GammaParticle(725960.0, 0.00171) }, { 0.0019d, new GammaParticle(730710.0, 0.0017) }, { 0.0072d, new GammaParticle(738070.0, 0.00168) }, { 0.0072d, new GammaParticle(738070.0, 0.00168) }, { 0.0034999999999999996d, new GammaParticle(774310.0, 0.0016) }, { 0.003d, new GammaParticle(782470.0, 0.00158) }, { 0.0013d, new GammaParticle(856710.0, 0.00145) }, { 0.0036d, new GammaParticle(511000.0, 0.00243) }, { 0.278548019784065d, new GammaParticle(8215.0, 0.15092) }, { 0.2564819057249023d, new GammaParticle(49773.0, 0.02491) }, { 0.4528282233843614d, new GammaParticle(50742.0, 0.02443) }, { 0.148054415837886d, new GammaParticle(57612.0, 0.02152) }, { 0.18654856395573635d, new GammaParticle(58257.0, 0.02128) }, { 0.03849414811785036d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    