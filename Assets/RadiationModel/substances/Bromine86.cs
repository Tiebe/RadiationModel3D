using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine86 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine86";
        public override double halfLife { get; } = 55.1d;
        public override double atomicWeight { get; } = 85.91881d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton86() }, { 1.0d, new BetaParticle(-1, 3816838.0) }, { 0.017112000000000002d, new GammaParticle(501250.0, 0.00247) }, { 0.0037819999999999998d, new GammaParticle(538040.0, 0.0023) }, { 0.0048980000000000004d, new GammaParticle(576720.0, 0.00215) }, { 0.008246d, new GammaParticle(660020.0, 0.00188) }, { 0.00868d, new GammaParticle(666770.0, 0.00186) }, { 0.011408d, new GammaParticle(685370.0, 0.00181) }, { 0.0068200000000000005d, new GammaParticle(749500.0, 0.00165) }, { 0.035774d, new GammaParticle(784960.0, 0.00158) }, { 0.027280000000000002d, new GammaParticle(803300.0, 0.00154) }, { 0.0026040000000000004d, new GammaParticle(899810.0, 0.00138) }, { 0.004402d, new GammaParticle(1155920.0, 0.00107) }, { 0.066092d, new GammaParticle(1217020.0, 0.00102) }, { 0.07688d, new GammaParticle(1286080.0, 0.00096) }, { 0.003844d, new GammaParticle(1306570.0, 0.00095) }, { 0.10167999999999999d, new GammaParticle(1361630.0, 0.00091) }, { 0.10167999999999999d, new GammaParticle(1389730.0, 0.00089) }, { 0.0034100000000000003d, new GammaParticle(1398480.0, 0.00089) }, { 0.07440000000000001d, new GammaParticle(1465090.0, 0.00085) }, { 0.0775d, new GammaParticle(1534240.0, 0.00081) }, { 0.62d, new GammaParticle(1564600.0, 0.00079) }, { 0.0037199999999999998d, new GammaParticle(1770300.0, 0.0007) }, { 0.06572d, new GammaParticle(1966270.0, 0.00063) }, { 0.09734d, new GammaParticle(2349370.0, 0.00053) }, { 0.0069440000000000005d, new GammaParticle(2387790.0, 0.00052) }, { 0.008060000000000001d, new GammaParticle(2418240.0, 0.00051) }, { 0.004464d, new GammaParticle(2471300.0, 0.0005) }, { 0.003968d, new GammaParticle(2480400.0, 0.0005) }, { 0.19096d, new GammaParticle(2751060.0, 0.00045) }, { 0.02046d, new GammaParticle(2925930.0, 0.00042) }, { 0.004836d, new GammaParticle(2973200.0, 0.00042) }, { 0.009734d, new GammaParticle(3009000.0, 0.00041) }, { 0.002356d, new GammaParticle(3064380.0, 0.0004) }, { 0.0030380000000000003d, new GammaParticle(3240600.0, 0.00038) }, { 0.008432d, new GammaParticle(3573300.0, 0.00035) }, { 0.007936d, new GammaParticle(3758800.0, 0.00033) }, { 0.009300000000000001d, new GammaParticle(3783100.0, 0.00033) }, { 0.00434d, new GammaParticle(4136500.0, 0.0003) }, { 0.001178d, new GammaParticle(4316500.0, 0.00029) }, { 0.008494d, new GammaParticle(4401200.0, 0.00028) }, { 0.002046d, new GammaParticle(4415300.0, 0.00028) }, { 0.004402d, new GammaParticle(4721000.0, 0.00026) }, { 0.012276d, new GammaParticle(4885120.0, 0.00025) }, { 0.001364d, new GammaParticle(5032600.0, 0.00025) }, { 0.0558d, new GammaParticle(5405800.0, 0.00023) }, { 0.00062d, new GammaParticle(5466100.0, 0.00023) }, { 0.03596d, new GammaParticle(5517580.0, 0.00022) }, { 0.000744d, new GammaParticle(5575000.0, 0.00022) }, { 0.00062d, new GammaParticle(6088900.0, 0.0002) }, { 0.00155d, new GammaParticle(6160300.0, 0.0002) }, { 0.008308d, new GammaParticle(6211600.0, 0.0002) }, { 0.000682d, new GammaParticle(6720200.0, 0.00018) }, { 0.001178d, new GammaParticle(6768000.0, 0.00018) } } },

        };
    }
}
    