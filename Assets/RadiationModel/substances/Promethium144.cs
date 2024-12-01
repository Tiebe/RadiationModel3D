using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium144";
        public override double halfLife { get; } = 31363200.0d;
        public override double atomicWeight { get; } = 143.9126d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium144()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0017908199999999998d, new GammaParticle(301700.0, 0.00411)), new(0.437756d, new GammaParticle(476780.0, 0.0026)), new(0.00189031d, new GammaParticle(582400.0, 0.00213)), new(0.9849509999999999d, new GammaParticle(618010.0, 0.00201)), new(0.00547195d, new GammaParticle(694000.0, 0.00179)), new(0.9948999999999999d, new GammaParticle(696490.0, 0.00178)), new(0.01502299d, new GammaParticle(778570.0, 0.00159)), new(0.00547195d, new GammaParticle(814140.0, 0.00152)), new(0.00038801099999999995d, new GammaParticle(890100.0, 0.00139)), new(4.87501e-06d, new GammaParticle(1396600.0, 0.00089)), new(4.27807e-05d, new GammaParticle(1413000.0, 0.00088)), new(1.9898e-06d, new GammaParticle(1508100.0, 0.00082)), new(1.2933700000000002e-06d, new GammaParticle(1510600.0, 0.00082)), new(0.1210483372640625d, new GammaParticle(5870.0, 0.21122)), new(0.2206988882125411d, new GammaParticle(36848.0, 0.03365)), new(0.40192840687040815d, new GammaParticle(37362.0, 0.03318)), new(0.12343573741819487d, new GammaParticle(42380.0, 0.02926)), new(0.15515872193467095d, new GammaParticle(42810.0, 0.02896)), new(0.03172298451647608d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    