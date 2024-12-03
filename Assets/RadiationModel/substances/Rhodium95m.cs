using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium95m";
        public override double halfLife { get; } = 117.6d;
        public override double atomicWeight { get; } = 94.91648d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium95()), new(0.8d, new GammaParticle(543300.0, 0.00228)), new(0.0037965046079999998d, new GammaParticle(2892.0, 0.42871)), new(0.01560233415196124d, new GammaParticle(20073.0, 0.06177)), new(0.029538686391444982d, new GammaParticle(20215.0, 0.06133)), new(0.00802162903652982d, new GammaParticle(22806.0, 0.05436)), new(0.00935321945659377d, new GammaParticle(22957.0, 0.05401)), new(0.00133159042006395d, new GammaParticle(23170.0, 0.05351)) } },
            { 0.12d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.08d, new GammaParticle(787700.0, 0.00157)), new(0.008d, new GammaParticle(2821000.0, 0.00044)), new(0.009000000000000001d, new GammaParticle(3186200.0, 0.00039)), new(0.02d, new GammaParticle(3407100.0, 0.00036)), new(0.008d, new GammaParticle(3757400.0, 0.00033)), new(0.013000000000000001d, new GammaParticle(3824400.0, 0.00032)), new(0.006d, new GammaParticle(4207800.0, 0.00029)), new(0.006999999999999999d, new GammaParticle(4242000.0, 0.00029)), new(0.01d, new GammaParticle(4336500.0, 0.00029)), new(0.165d, new GammaParticle(511000.0, 0.00243)), new(0.0015203993699999998d, new GammaParticle(2737.0, 0.45299)), new(0.006814883479682039d, new GammaParticle(19150.0, 0.06474)), new(0.012931467703381478d, new GammaParticle(19279.0, 0.06431)), new(0.0034751538872086823d, new GammaParticle(21736.0, 0.05704)), new(0.004038128816936489d, new GammaParticle(21875.0, 0.05668)), new(0.0005629749297278065d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    