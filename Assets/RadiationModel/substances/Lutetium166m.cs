using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium166m";
        public override double halfLife { get; } = 84.6d;
        public override double atomicWeight { get; } = 165.93989d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.58d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium166()), new(0.12539999999999998d, new GammaParticle(102380.0, 0.01211)), new(0.0143d, new GammaParticle(152490.0, 0.00813)), new(0.1518d, new GammaParticle(228130.0, 0.00543)), new(0.11d, new GammaParticle(285070.0, 0.00435)), new(0.0044d, new GammaParticle(345000.0, 0.00359)), new(0.0044d, new GammaParticle(345000.0, 0.00359)), new(0.0044d, new GammaParticle(407000.0, 0.00305)), new(0.0121d, new GammaParticle(412200.0, 0.00301)), new(0.0209d, new GammaParticle(421260.0, 0.00294)), new(0.0077d, new GammaParticle(464290.0, 0.00267)), new(0.0055000000000000005d, new GammaParticle(470400.0, 0.00264)), new(0.0297d, new GammaParticle(526010.0, 0.00236)), new(0.0077d, new GammaParticle(568500.0, 0.00218)), new(0.0319d, new GammaParticle(570930.0, 0.00217)), new(0.0121d, new GammaParticle(581000.0, 0.00213)), new(0.0066d, new GammaParticle(625300.0, 0.00198)), new(0.0352d, new GammaParticle(643200.0, 0.00193)), new(0.0066d, new GammaParticle(680900.0, 0.00182)), new(0.009899999999999999d, new GammaParticle(701900.0, 0.00177)), new(0.044000000000000004d, new GammaParticle(705080.0, 0.00176)), new(0.0143d, new GammaParticle(708820.0, 0.00175)), new(0.0044d, new GammaParticle(747100.0, 0.00166)), new(0.09789999999999999d, new GammaParticle(811920.0, 0.00153)), new(0.1023d, new GammaParticle(830060.0, 0.00149)), new(0.0264d, new GammaParticle(832490.0, 0.00149)), new(0.0121d, new GammaParticle(866400.0, 0.00143)), new(0.0803d, new GammaParticle(932350.0, 0.00133)), new(0.0825d, new GammaParticle(936790.0, 0.00132)), new(0.022000000000000002d, new GammaParticle(984600.0, 0.00126)), new(0.0066d, new GammaParticle(1023800.0, 0.00121)), new(0.0088d, new GammaParticle(1054700.0, 0.00118)), new(0.0055000000000000005d, new GammaParticle(1060280.0, 0.00117)), new(0.0121d, new GammaParticle(1276920.0, 0.00097)), new(0.0385d, new GammaParticle(1283450.0, 0.00097)), new(0.0055000000000000005d, new GammaParticle(1349400.0, 0.00092)), new(0.009899999999999999d, new GammaParticle(1354350.0, 0.00092)), new(0.0121d, new GammaParticle(1504900.0, 0.00082)), new(0.0022d, new GammaParticle(1582200.0, 0.00078)), new(0.0132d, new GammaParticle(1698700.0, 0.00073)), new(0.009899999999999999d, new GammaParticle(1801300.0, 0.00069)), new(0.0066d, new GammaParticle(1974000.0, 0.00063)), new(0.3172d, new GammaParticle(511000.0, 0.00243)), new(0.119839751734654d, new GammaParticle(8502.0, 0.14583)), new(0.09042625895029095d, new GammaParticle(51354.0, 0.02414)), new(0.1593976008289987d, new GammaParticle(52389.0, 0.02367)), new(0.052322348428001896d, new GammaParticle(59481.0, 0.02084)), new(0.0659784813677104d, new GammaParticle(60151.0, 0.02061)), new(0.013656132939708496d, new GammaParticle(60961.0, 0.02034)) } },
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium166()), new(4.9e-06d, new GammaParticle(34370.0, 0.03607)), new(0.075516d, new GammaParticle(8810.0, 0.14073)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    