using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium57";
        public override double halfLife { get; } = 21.1d;
        public override double atomicWeight { get; } = 56.94361d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese57() }, { 1.0d, new BetaParticle(-1, 2480650.0) }, { 0.0832d, new GammaParticle(83400.0, 0.01487) }, { 0.029224d, new GammaParticle(205800.0, 0.00602) }, { 0.00494d, new GammaParticle(342900.0, 0.00362) }, { 0.001872d, new GammaParticle(479100.0, 0.00259) }, { 0.0054600000000000004d, new GammaParticle(684100.0, 0.00181) }, { 0.0034839999999999997d, new GammaParticle(766500.0, 0.00162) }, { 0.08163999999999999d, new GammaParticle(850200.0, 0.00146) }, { 0.008476000000000001d, new GammaParticle(1055800.0, 0.00117) }, { 0.014092d, new GammaParticle(1129900.0, 0.0011) }, { 0.005876d, new GammaParticle(1209200.0, 0.00103) }, { 0.007592d, new GammaParticle(1292200.0, 0.00096) }, { 0.0032240000000000003d, new GammaParticle(1327300.0, 0.00093) }, { 0.01196d, new GammaParticle(1335700.0, 0.00093) }, { 0.00936d, new GammaParticle(1409300.0, 0.00088) }, { 0.00962d, new GammaParticle(1492700.0, 0.00083) }, { 0.049244d, new GammaParticle(1535000.0, 0.00081) }, { 0.002184d, new GammaParticle(1642200.0, 0.00075) }, { 0.052000000000000005d, new GammaParticle(1752100.0, 0.00071) }, { 0.013935999999999999d, new GammaParticle(1835200.0, 0.00068) }, { 0.01196d, new GammaParticle(1852000.0, 0.00067) }, { 0.002236d, new GammaParticle(2063500.0, 0.0006) }, { 0.002444d, new GammaParticle(2257200.0, 0.00055) }, { 0.008788d, new GammaParticle(2410000.0, 0.00051) }, { 0.008112000000000001d, new GammaParticle(2493100.0, 0.0005) }, { 0.004472d, new GammaParticle(2618300.0, 0.00047) }, { 2.780624713932e-05d, new GammaParticle(660.0, 1.87855) }, { 0.0003581069600914972d, new GammaParticle(5888.0, 0.21057) }, { 0.0007023082174769507d, new GammaParticle(5899.0, 0.21018) }, { 0.00014411042263155207d, new GammaParticle(6512.0, 0.19039) }, { 0.00014411042263155207d, new GammaParticle(6512.0, 0.19039) } } },

        };
    }
}
    