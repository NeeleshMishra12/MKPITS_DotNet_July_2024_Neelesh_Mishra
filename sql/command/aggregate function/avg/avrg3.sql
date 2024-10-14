SELECT ProductID, AVG(Rating) AS AverageRating
FROM ProductReviews
GROUP BY ProductID
HAVING COUNT(ReviewID) > 10;
