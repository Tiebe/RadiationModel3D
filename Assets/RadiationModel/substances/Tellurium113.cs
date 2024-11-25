using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium113";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 112.91589d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin113() }, { 1.0d, new BetaParticle(1, 4990550.0) }, { 0.00462d, new GammaParticle(238400.0, 0.0052) }, { 0.00594d, new GammaParticle(269800.0, 0.0046) }, { 0.0264d, new GammaParticle(391800.0, 0.00316) }, { 0.00242d, new GammaParticle(437700.0, 0.00283) }, { 0.0066d, new GammaParticle(443300.0, 0.0028) }, { 0.0055000000000000005d, new GammaParticle(473100.0, 0.00262) }, { 0.0066d, new GammaParticle(583000.0, 0.00213) }, { 0.011000000000000001d, new GammaParticle(609300.0, 0.00203) }, { 0.0638d, new GammaParticle(644800.0, 0.00192) }, { 0.00792d, new GammaParticle(647500.0, 0.00191) }, { 0.00968d, new GammaParticle(737000.0, 0.00168) }, { 0.22d, new GammaParticle(814400.0, 0.00152) }, { 0.013859999999999999d, new GammaParticle(915000.0, 0.00136) }, { 0.1298d, new GammaParticle(1018100.0, 0.00122) }, { 0.0154d, new GammaParticle(1039500.0, 0.00119) }, { 0.0154d, new GammaParticle(1071700.0, 0.00116) }, { 0.1232d, new GammaParticle(1181000.0, 0.00105) }, { 0.0132d, new GammaParticle(1206600.0, 0.00103) }, { 0.0088d, new GammaParticle(1245400.0, 0.001) }, { 0.055d, new GammaParticle(1256700.0, 0.00099) }, { 0.0176d, new GammaParticle(1301300.0, 0.00095) }, { 0.0132d, new GammaParticle(1317900.0, 0.00094) }, { 0.011659999999999998d, new GammaParticle(1358000.0, 0.00091) }, { 0.0176d, new GammaParticle(1449700.0, 0.00086) }, { 0.0176d, new GammaParticle(1460000.0, 0.00085) }, { 0.0154d, new GammaParticle(1515100.0, 0.00082) }, { 0.022000000000000002d, new GammaParticle(1550300.0, 0.0008) }, { 0.0132d, new GammaParticle(1567200.0, 0.00079) }, { 0.008579999999999999d, new GammaParticle(1719800.0, 0.00072) }, { 0.0176d, new GammaParticle(1803600.0, 0.00069) }, { 0.0242d, new GammaParticle(1868100.0, 0.00066) }, { 0.0088d, new GammaParticle(1944300.0, 0.00064) }, { 0.0154d, new GammaParticle(2047800.0, 0.00061) }, { 0.0286d, new GammaParticle(2093700.0, 0.00059) }, { 0.019799999999999998d, new GammaParticle(2115500.0, 0.00059) }, { 0.019799999999999998d, new GammaParticle(2221200.0, 0.00056) }, { 0.0264d, new GammaParticle(2535200.0, 0.00049) }, { 0.0154d, new GammaParticle(2552400.0, 0.00049) }, { 0.0176d, new GammaParticle(2606500.0, 0.00048) }, { 1.8119999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.0076d, new GammaParticle(3941.0, 0.3146) }, { 0.022400000000000003d, new GammaParticle(26111.0, 0.04748) }, { 0.0418d, new GammaParticle(26359.0, 0.04704) }, { 0.011899999999999999d, new GammaParticle(29821.0, 0.04158) }, { 0.0144d, new GammaParticle(30069.0, 0.04123) }, { 0.00246d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    