using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium119m";
        public override double halfLife { get; } = 1080.0d;
        public override double atomicWeight { get; } = 118.90619d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.956d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin119()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(8.999999999999999e-05d, new GammaParticle(896600.0, 0.00138)), new(0.00021999999999999998d, new GammaParticle(897500.0, 0.00138)), new(0.00024d, new GammaParticle(920500.0, 0.00135)), new(7.000000000000001e-05d, new GammaParticle(921400.0, 0.00135)), new(0.0021988d, new GammaParticle(1065550.0, 0.00116)), new(0.00043999999999999996d, new GammaParticle(1089900.0, 0.00114)), new(0.00092d, new GammaParticle(1163850.0, 0.00107)), new(0.00017999999999999998d, new GammaParticle(1187790.0, 0.00104)), new(0.00035000000000000005d, new GammaParticle(1225700.0, 0.00101)), new(0.00125d, new GammaParticle(1249710.0, 0.00099)), new(6.6e-05d, new GammaParticle(1330000.0, 0.00093)), new(2e-05d, new GammaParticle(1354000.0, 0.00092)), new(0.00015d, new GammaParticle(1506900.0, 0.00082)), new(4.919619081264e-07d, new GammaParticle(3753.0, 0.33036)), new(1.5479677428669195e-06d, new GammaParticle(25044.0, 0.04951)), new(2.8971883639657863e-06d, new GammaParticle(25271.0, 0.04906)), new(8.192159040662448e-07d, new GammaParticle(28579.0, 0.04338)), new(9.80601437167295e-07d, new GammaParticle(28810.0, 0.04304)), new(1.613855331010502e-07d, new GammaParticle(29107.0, 0.0426)) } },
            { 0.044000000000000004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium119()), new(0.0172d, new GammaParticle(311390.0, 0.00398)), new(0.0015334240320000001d, new GammaParticle(3571.0, 0.3472)), new(0.004596844116040421d, new GammaParticle(24001.0, 0.05166)), new(0.008624473013209046d, new GammaParticle(24209.0, 0.05121)), new(0.0024198343451685158d, new GammaParticle(27367.0, 0.0453)), new(0.002879602870750534d, new GammaParticle(27581.0, 0.04495)), new(0.000459768525582018d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    