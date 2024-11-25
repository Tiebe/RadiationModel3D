using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc78 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc78";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 77.93829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium78() }, { 1.0d, new BetaParticle(-1, 3110450.0) }, { 0.025901d, new GammaParticle(60240.0, 0.02058) }, { 0.0059265d, new GammaParticle(92150.0, 0.01345) }, { 0.034242d, new GammaParticle(112290.0, 0.01104) }, { 0.055753000000000004d, new GammaParticle(119360.0, 0.01039) }, { 0.007024d, new GammaParticle(132680.0, 0.00934) }, { 0.017121d, new GammaParticle(170710.0, 0.00726) }, { 0.02634d, new GammaParticle(172530.0, 0.00719) }, { 0.28096d, new GammaParticle(181680.0, 0.00682) }, { 0.023267000000000003d, new GammaParticle(187810.0, 0.0066) }, { 0.439d, new GammaParticle(224750.0, 0.00552) }, { 0.029413d, new GammaParticle(262210.0, 0.00473) }, { 0.008341d, new GammaParticle(275300.0, 0.0045) }, { 0.164625d, new GammaParticle(281340.0, 0.00441) }, { 0.032486d, new GammaParticle(303380.0, 0.00409) }, { 0.032925d, new GammaParticle(321930.0, 0.00385) }, { 0.027218d, new GammaParticle(342200.0, 0.00362) }, { 0.038632d, new GammaParticle(343930.0, 0.0036) }, { 0.072874d, new GammaParticle(354220.0, 0.0035) }, { 0.018438d, new GammaParticle(386200.0, 0.00321) }, { 0.007902d, new GammaParticle(395480.0, 0.00314) }, { 0.008341d, new GammaParticle(413070.0, 0.003) }, { 0.009658d, new GammaParticle(440500.0, 0.00281) }, { 0.010097d, new GammaParticle(446300.0, 0.00278) }, { 0.19711099999999998d, new GammaParticle(453930.0, 0.00273) }, { 0.010097d, new GammaParticle(537580.0, 0.00231) }, { 0.208525d, new GammaParticle(635560.0, 0.00195) }, { 0.007463d, new GammaParticle(722800.0, 0.00172) }, { 0.008341d, new GammaParticle(727000.0, 0.00171) }, { 0.009219d, new GammaParticle(744100.0, 0.00167) }, { 0.038632d, new GammaParticle(749700.0, 0.00165) }, { 0.005268d, new GammaParticle(762100.0, 0.00163) }, { 0.011853d, new GammaParticle(788200.0, 0.00157) }, { 0.005707d, new GammaParticle(797600.0, 0.00155) }, { 0.033364d, new GammaParticle(808040.0, 0.00153) }, { 0.018438d, new GammaParticle(818370.0, 0.00152) }, { 0.24540099999999998d, new GammaParticle(860300.0, 0.00144) }, { 0.022389000000000003d, new GammaParticle(909050.0, 0.00136) }, { 0.012731d, new GammaParticle(957840.0, 0.00129) }, { 0.066289d, new GammaParticle(979760.0, 0.00127) }, { 0.086922d, new GammaParticle(1006200.0, 0.00123) }, { 0.007902d, new GammaParticle(1157300.0, 0.00107) }, { 0.02634d, new GammaParticle(1174300.0, 0.00106) }, { 0.049607d, new GammaParticle(1345240.0, 0.00092) }, { 0.003073d, new GammaParticle(1558000.0, 0.0008) }, { 0.011414d, new GammaParticle(1570000.0, 0.00079) }, { 0.003951d, new GammaParticle(1623900.0, 0.00076) }, { 0.01317d, new GammaParticle(1675200.0, 0.00074) }, { 0.007024d, new GammaParticle(1926900.0, 0.00064) }, { 0.006585d, new GammaParticle(1970300.0, 0.00063) }, { 0.011853d, new GammaParticle(2026800.0, 0.00061) }, { 0.007902d, new GammaParticle(2103600.0, 0.00059) }, { 0.047851d, new GammaParticle(2205660.0, 0.00056) }, { 0.007902d, new GammaParticle(2489400.0, 0.0005) }, { 0.009658d, new GammaParticle(2563900.0, 0.00048) }, { 0.009658d, new GammaParticle(2626700.0, 0.00047) }, { 0.010536d, new GammaParticle(2693600.0, 0.00046) }, { 0.01317d, new GammaParticle(3553900.0, 0.00035) } } },

        };
    }
}
    