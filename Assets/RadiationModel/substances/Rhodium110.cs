using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium110";
        public override double halfLife { get; } = 3.35d;
        public override double atomicWeight { get; } = 109.91108d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium110() }, { 1.0d, new BetaParticle(-1, 2750950.0) }, { 0.0178d, new GammaParticle(291600.0, 0.00425) }, { 0.01272d, new GammaParticle(357000.0, 0.00347) }, { 0.89d, new GammaParticle(373800.0, 0.00332) }, { 0.53d, new GammaParticle(373800.0, 0.00332) }, { 0.19757999999999998d, new GammaParticle(398600.0, 0.00311) }, { 0.07897d, new GammaParticle(439700.0, 0.00282) }, { 0.29281d, new GammaParticle(439800.0, 0.00282) }, { 0.07209d, new GammaParticle(477800.0, 0.00259) }, { 0.03204d, new GammaParticle(501900.0, 0.00247) }, { 0.06052d, new GammaParticle(544400.0, 0.00228) }, { 0.38270000000000004d, new GammaParticle(546900.0, 0.00227) }, { 0.011659999999999998d, new GammaParticle(572600.0, 0.00217) }, { 0.13528d, new GammaParticle(584600.0, 0.00212) }, { 0.03649d, new GammaParticle(588800.0, 0.00211) }, { 0.16287d, new GammaParticle(653300.0, 0.0019) }, { 0.29014d, new GammaParticle(687700.0, 0.0018) }, { 0.03975d, new GammaParticle(796700.0, 0.00156) }, { 0.00979d, new GammaParticle(803500.0, 0.00154) }, { 0.10235d, new GammaParticle(813600.0, 0.00152) }, { 0.02915d, new GammaParticle(813700.0, 0.00152) }, { 0.0178d, new GammaParticle(817600.0, 0.00152) }, { 0.21271d, new GammaParticle(838200.0, 0.00148) }, { 0.00848d, new GammaParticle(840500.0, 0.00148) }, { 0.08900000000000001d, new GammaParticle(890500.0, 0.00139) }, { 0.17355d, new GammaParticle(904500.0, 0.00137) }, { 0.02848d, new GammaParticle(979200.0, 0.00127) }, { 0.06942d, new GammaParticle(1048500.0, 0.00118) }, { 0.01424d, new GammaParticle(1049500.0, 0.00118) }, { 0.0623d, new GammaParticle(1086500.0, 0.00114) }, { 0.005829999999999999d, new GammaParticle(1214400.0, 0.00102) }, { 0.01958d, new GammaParticle(1216500.0, 0.00102) }, { 0.07209d, new GammaParticle(1230900.0, 0.00101) }, { 0.02492d, new GammaParticle(1340000.0, 0.00093) }, { 0.08277d, new GammaParticle(1392100.0, 0.00089) }, { 0.04183d, new GammaParticle(1406600.0, 0.00088) }, { 0.00979d, new GammaParticle(1579200.0, 0.00079) }, { 0.0356d, new GammaParticle(1593600.0, 0.00078) }, { 0.0178d, new GammaParticle(1869500.0, 0.00066) }, { 0.04539d, new GammaParticle(1884100.0, 0.00066) }, { 0.0012049164846698d, new GammaParticle(3053.0, 0.40611) }, { 0.000411269046861d, new GammaParticle(3053.0, 0.40611) }, { 0.0016241163755163779d, new GammaParticle(21020.0, 0.05898) }, { 0.0047790608816287074d, new GammaParticle(21020.0, 0.05898) }, { 0.009029021125314013d, new GammaParticle(21177.0, 0.05855) }, { 0.0030684231541968222d, new GammaParticle(21177.0, 0.05855) }, { 0.0024771935156045104d, new GammaParticle(23904.0, 0.05187) }, { 0.0008418496130656416d, new GammaParticle(23904.0, 0.05187) }, { 0.002898316413257277d, new GammaParticle(24070.0, 0.05151) }, { 0.0009849640472868006d, new GammaParticle(24070.0, 0.05151) }, { 0.0001431144342211591d, new GammaParticle(24297.0, 0.05103) }, { 0.00042112289765276675d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    