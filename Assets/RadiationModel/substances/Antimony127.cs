using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony127 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony127";
        public override double halfLife { get; } = 332640.0d;
        public override double atomicWeight { get; } = 126.90693d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium127() }, { 1.0d, new BetaParticle(-1, 791250.0) }, { 0.014352d, new GammaParticle(61100.0, 0.02029) }, { 0.001472d, new GammaParticle(154300.0, 0.00804) }, { 0.085008d, new GammaParticle(252400.0, 0.00491) }, { 0.006624d, new GammaParticle(280400.0, 0.00442) }, { 0.02024d, new GammaParticle(290800.0, 0.00426) }, { 0.002944d, new GammaParticle(293300.0, 0.00423) }, { 0.002576d, new GammaParticle(310000.0, 0.004) }, { 0.009568d, new GammaParticle(391800.0, 0.00316) }, { 0.038272d, new GammaParticle(412100.0, 0.00301) }, { 0.006992000000000001d, new GammaParticle(441000.0, 0.00281) }, { 0.043424d, new GammaParticle(445100.0, 0.00279) }, { 0.00184d, new GammaParticle(451000.0, 0.00275) }, { 0.001104d, new GammaParticle(456000.0, 0.00272) }, { 0.25796800000000003d, new GammaParticle(473000.0, 0.00262) }, { 0.0077280000000000005d, new GammaParticle(502800.0, 0.00247) }, { 0.02944d, new GammaParticle(543300.0, 0.00228) }, { 0.003312d, new GammaParticle(584200.0, 0.00212) }, { 0.044528d, new GammaParticle(603500.0, 0.00205) }, { 0.0006624d, new GammaParticle(624000.0, 0.00199) }, { 0.004416d, new GammaParticle(637800.0, 0.00194) }, { 0.00368d, new GammaParticle(652300.0, 0.0019) }, { 0.00736d, new GammaParticle(667500.0, 0.00186) }, { 0.005520000000000001d, new GammaParticle(682300.0, 0.00182) }, { 0.368d, new GammaParticle(685700.0, 0.00181) }, { 0.036432d, new GammaParticle(698500.0, 0.00178) }, { 0.018768d, new GammaParticle(722200.0, 0.00172) }, { 0.001472d, new GammaParticle(745900.0, 0.00166) }, { 0.000736d, new GammaParticle(763700.0, 0.00162) }, { 0.151248d, new GammaParticle(783700.0, 0.00158) }, { 0.0040479999999999995d, new GammaParticle(817000.0, 0.00152) }, { 0.002208d, new GammaParticle(820600.0, 0.00151) }, { 0.005152d, new GammaParticle(924400.0, 0.00134) }, { 0.00368d, new GammaParticle(1141600.0, 0.00109) }, { 0.00040480000000000003d, new GammaParticle(1155200.0, 0.00107) }, { 0.00368d, new GammaParticle(1290300.0, 0.00096) }, { 0.000736d, new GammaParticle(1377900.0, 0.0009) }, { 0.004233742285284576d, new GammaParticle(4135.0, 0.29984) }, { 0.01074141543254858d, new GammaParticle(27202.0, 0.04558) }, { 0.020002635814801824d, new GammaParticle(27473.0, 0.04513) }, { 0.00572440592658143d, new GammaParticle(31093.0, 0.03988) }, { 0.006966602012649601d, new GammaParticle(31359.0, 0.03954) }, { 0.0012421960860681703d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    