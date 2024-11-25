using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine82 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine82";
        public override double halfLife { get; } = 127015.2d;
        public override double atomicWeight { get; } = 81.9168d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton82() }, { 1.0d, new BetaParticle(-1, 1546547.5) }, { 0.007189600000000001d, new GammaParticle(92188.0, 0.01345) }, { 0.00061864d, new GammaParticle(100948.0, 0.01228) }, { 0.00011704d, new GammaParticle(129340.0, 0.00959) }, { 0.0009196d, new GammaParticle(137244.0, 0.00903) }, { 8.36e-05d, new GammaParticle(179800.0, 0.0069) }, { 0.00011704d, new GammaParticle(182840.0, 0.00678) }, { 3.3440000000000005e-05d, new GammaParticle(214800.0, 0.00577) }, { 0.0228228d, new GammaParticle(221478.0, 0.0056) }, { 0.00018392d, new GammaParticle(271960.0, 0.00456) }, { 0.0080256d, new GammaParticle(273492.0, 0.00453) }, { 8.8616e-05d, new GammaParticle(280730.0, 0.00442) }, { 7.3568e-05d, new GammaParticle(332780.0, 0.00373) }, { 0.0008610800000000001d, new GammaParticle(401249.0, 0.00309) }, { 0.00021736d, new GammaParticle(470070.0, 0.00264) }, { 0.717288d, new GammaParticle(554352.0, 0.00224) }, { 7.6912e-05d, new GammaParticle(599290.0, 0.00207) }, { 0.0122892d, new GammaParticle(606358.0, 0.00204) }, { 0.437228d, new GammaParticle(619105.0, 0.002) }, { 0.28424d, new GammaParticle(698361.0, 0.00178) }, { 0.00063536d, new GammaParticle(735645.0, 0.00169) }, { 0.836d, new GammaParticle(776511.0, 0.0016) }, { 0.24160399999999999d, new GammaParticle(827826.0, 0.0015) }, { 2.5079999999999997e-05d, new GammaParticle(932100.0, 0.00133) }, { 0.0037787199999999997d, new GammaParticle(952029.0, 0.0013) }, { 0.0130416d, new GammaParticle(1007589.0, 0.00123) }, { 0.27588d, new GammaParticle(1044005.0, 0.00119) }, { 0.00071896d, new GammaParticle(1072554.0, 0.00116) }, { 0.0064372d, new GammaParticle(1081288.0, 0.00115) }, { 2.5079999999999997e-05d, new GammaParticle(1099900.0, 0.00113) }, { 0.00013376000000000002d, new GammaParticle(1173432.0, 0.00106) }, { 0.00088616d, new GammaParticle(1180209.0, 0.00105) }, { 0.269192d, new GammaParticle(1317485.0, 0.00094) }, { 2.5079999999999997e-05d, new GammaParticle(1395200.0, 0.00089) }, { 3.3440000000000005e-05d, new GammaParticle(1426000.0, 0.00087) }, { 0.163856d, new GammaParticle(1474895.0, 0.00084) }, { 0.00739024d, new GammaParticle(1650346.0, 0.00075) }, { 0.00111188d, new GammaParticle(1779623.0, 0.0007) }, { 0.00034276d, new GammaParticle(1871807.0, 0.00066) }, { 0.00038456d, new GammaParticle(1956740.0, 0.00063) }, { 0.00014650109511644375d, new GammaParticle(1648.0, 0.75233) }, { 0.0010552897841937623d, new GammaParticle(12596.0, 0.09843) }, { 0.002034881959494335d, new GammaParticle(12649.0, 0.09802) }, { 0.00048761158419206266d, new GammaParticle(14169.0, 0.0875) }, { 0.0005367628318786226d, new GammaParticle(14209.0, 0.08726) }, { 4.915124768655992e-05d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    