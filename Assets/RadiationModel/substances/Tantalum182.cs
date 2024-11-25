using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182";
        public override double halfLife { get; } = 9913536.0d;
        public override double atomicWeight { get; } = 181.95015d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten182() }, { 1.0d, new BetaParticle(-1, 907700.0) }, { 0.008739519999999999d, new GammaParticle(31737.7, 0.03907) }, { 0.00267824d, new GammaParticle(42714.8, 0.02903) }, { 0.00029954d, new GammaParticle(44660.0, 0.02776) }, { 0.0301302d, new GammaParticle(65722.15, 0.01886) }, { 0.42922319999999997d, new GammaParticle(67749.7, 0.0183) }, { 0.02653572d, new GammaParticle(84680.24, 0.01464) }, { 0.1420172d, new GammaParticle(100105.95, 0.01239) }, { 0.00107482d, new GammaParticle(110393.0, 0.01123) }, { 0.018708916d, new GammaParticle(113671.7, 0.01091) }, { 0.00444024d, new GammaParticle(116417.9, 0.01065) }, { 2.36108e-05d, new GammaParticle(121500.0, 0.0102) }, { 0.07016284d, new GammaParticle(152429.91, 0.00813) }, { 0.02671192d, new GammaParticle(156386.4, 0.00793) }, { 0.031187399999999997d, new GammaParticle(179393.81, 0.00691) }, { 0.014649268d, new GammaParticle(198351.87, 0.00625) }, { 0.07566028d, new GammaParticle(222108.5, 0.00558) }, { 0.036438160000000004d, new GammaParticle(229320.7, 0.00541) }, { 0.036121d, new GammaParticle(264074.0, 0.0047) }, { 0.0001131204d, new GammaParticle(351020.0, 0.00353) }, { 0.00014095999999999998d, new GammaParticle(829900.0, 0.00149) }, { 0.000574412d, new GammaParticle(891700.0, 0.00139) }, { 0.0061352839999999995d, new GammaParticle(928000.0, 0.00134) }, { 0.0034958080000000004d, new GammaParticle(959730.0, 0.00129) }, { 0.02086208d, new GammaParticle(1001700.0, 0.00124) }, { 6.6956e-05d, new GammaParticle(1035700.0, 0.0012) }, { 0.002389272d, new GammaParticle(1044420.0, 0.00119) }, { 0.004447288d, new GammaParticle(1113410.0, 0.00111) }, { 0.35240000000000005d, new GammaParticle(1121290.0, 0.00111) }, { 0.00732992d, new GammaParticle(1157302.0, 0.00107) }, { 0.00288968d, new GammaParticle(1158100.0, 0.00107) }, { 0.0008739520000000001d, new GammaParticle(1180850.0, 0.00105) }, { 0.16485271999999998d, new GammaParticle(1189040.0, 0.00104) }, { 0.27229948d, new GammaParticle(1221395.0, 0.00102) }, { 0.00236108d, new GammaParticle(1223600.0, 0.00101) }, { 0.11615104000000001d, new GammaParticle(1231004.0, 0.00101) }, { 0.015093292000000001d, new GammaParticle(1257407.0, 0.00099) }, { 0.006596927999999999d, new GammaParticle(1273719.0, 0.00097) }, { 0.013718932d, new GammaParticle(1289145.0, 0.00096) }, { 0.0025654719999999996d, new GammaParticle(1342730.0, 0.00092) }, { 0.002223644d, new GammaParticle(1373824.0, 0.0009) }, { 0.000729468d, new GammaParticle(1387390.0, 0.00089) }, { 0.00039574520000000004d, new GammaParticle(1410130.0, 0.00088) }, { 0.000306588d, new GammaParticle(1453120.0, 0.00085) }, { 0.23560870297331854d, new GammaParticle(9740.0, 0.12729) }, { 0.10052568389560236d, new GammaParticle(57983.0, 0.02138) }, { 0.17461470192044878d, new GammaParticle(59320.0, 0.0209) }, { 0.057878825273706205d, new GammaParticle(67335.0, 0.01841) }, { 0.07373762339870171d, new GammaParticle(68117.0, 0.0182) }, { 0.0158587981249955d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    